using ElevenLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenLab.Controllers
{
	public class HomeController : Controller
	{
		EmplDbContext db = new EmplDbContext();

		public ActionResult Index()
		{
			// получаем из бд все объекты 
			IEnumerable<Worker> workers = db.Workers;
			// передаем все объекты в динамическое свойство
			ViewBag.Workers = workers;

			IEnumerable<Position> positions = db.Positions;

			ViewBag.Positions = positions;

			SelectList idPosition = new SelectList(db.Positions, "Id", "Name");

			ViewBag.Id = idPosition;

			SelectList idWorker = new SelectList(db.Workers, "Id", "Surname");

			ViewBag.Id2 = idWorker;

			SelectList idWorker2 = new SelectList(db.Workers, "Id", "Surname");

			ViewBag.Id3 = idWorker2;

			return View();
		}

		[HttpGet]
		public ActionResult GetWorker(int idPosition)
		{
			var query = from x in db.Histories
						join y in db.Workers on x.WorkerId equals y.Id
						join z in db.Positions on x.PositionId equals z.Id
						where z.Id == idPosition
						select new FirstQuery
						{
							Name = y.Surname,
							Position = z.Name
						};

			query = query.Distinct();
			ViewBag.Worker = query.ToList();
			return View();
		}

		[HttpGet]
		public ActionResult GetPosition(int idWorker)
		{
			var query = from x in db.Histories
						join y in db.Workers on x.WorkerId equals y.Id
						join z in db.Positions on x.PositionId equals z.Id
						where y.Id == idWorker && x.Status == "Р"
						select new SecondQuery
						{
							Surname = y.Surname,
							Position = z.Name,
							Salary = z.Salary * x.WageRate,
							Date = x.DateOfEmployment
						};

			query = query.Distinct();
			ViewBag.Position = query.ToList();
			return View();
		}

		[HttpPost]
		public ActionResult GetWorkersDate(DateTime dateBegin, DateTime dateEnd)
		{
			var query = from x in db.Histories
						join y in db.Workers on x.WorkerId equals y.Id
						join z in db.Positions on x.PositionId equals z.Id
						where x.DateOfEmployment >= dateBegin && x.DateOfEmployment <= dateEnd
						select new ThirdQuery
						{
							Surname = y.Surname,
							Name = y.Name,
							Patranomyc = y.Patronymic
						};

			query = query.Distinct();
			ViewBag.EmplDate = query.ToList();
			return View();
		}

		public ActionResult GetMaxMinPosition()
		{
			var result = from ot in db.Histories
						 join v in db.Workers on ot.WorkerId equals v.Id
						 join c in db.Positions on ot.PositionId equals c.Id
						 where c.Salary * ot.WageRate == c.Salary
						 select new ForthQuery
						 {
							 Surname = v.Surname,
							 Name = v.Name,
							 Patronymic = v.Patronymic,
							 Position = c.Name,
							 Salary = c.Salary
						 };
			ViewBag.MinMax = result.ToList();
			return View();
		}

		[HttpGet]
		public ActionResult GetChronologic(int idWorker2)
		{
			var query = from x in db.Histories
						join y in db.Workers on x.WorkerId equals y.Id
						join z in db.Positions on x.PositionId equals z.Id
						where y.Id == idWorker2
						select new FifthQuery
						{
							NamePosition = z.Name,
							DateOfEmployment = x.DateOfEmployment,
							DateOfDismissal = x.DateOfDismissal,
							WhyDismissal = x.WhyDismissal
						};

			query = query.Distinct();
			ViewBag.Chronical = query.ToList();
			return View();
		}

		[HttpPost]
		public ActionResult GetWorkerSalary(string month, int year)
		{
			Dictionary<int, string> months = new Dictionary<int, string>(5);
			months.Add(1, "Январь");
			months.Add(2, "Февраль");
			months.Add(3, "Март");
			months.Add(4, "Апрель");
			months.Add(5, "Май");
			months.Add(6, "Июнь");
			months.Add(7, "Июль");
			months.Add(8, "Август");
			months.Add(9, "Сентябрь");
			months.Add(10, "Октябрь");
			months.Add(11, "Ноябрь");
			months.Add(12, "Декабрь");

			int mon = 1;//дефолт
			foreach (var i in months)
			{
				if (i.Value.Equals(month.Trim().ToLower()))
				{
					mon = i.Key;
					break;
				}
			}

			List<FirstFunction> list = new List<FirstFunction>();

			var salary = db.Histories.Where(x => x.YearSalary == year && x.OneMonthSalary == month).Select(x => x.PositionId).ToList();

			var results1 = from p in db.Histories
						   group new { p.WorkerId, p.PositionId, p.WageRate } by p.WorkerId into g
						   select new { PersonId = g.Key, Items = g.ToList() };


			foreach (var el in results1)
			{
				double sumOklad = 0;
				double premia = 0;
				double ndfl = 0;

				foreach (var l in salary)
				{
					if (el.Items.Select(x => x.PositionId).First() == l)
					{

						foreach (var t in el.Items)
						{
							int PodtId = Convert.ToInt32(t.PositionId);
							var f = db.Positions.Where(x => x.Id == PodtId).Select(x => x.Salary).FirstOrDefault();
							sumOklad += f * t.WageRate;
						}
						var result = db.Workers.Where(x => x.Id == el.PersonId).Select(x => new { x.Surname, x.DateOfBirth }).FirstOrDefault();
						if (result != null)
						{
							string name = result.Surname;
							int date = result.DateOfBirth.Month;
							if (date == mon)
								premia = sumOklad * 0.15;
							ndfl = sumOklad * 0.13 + premia * 0.13;
							if (sumOklad != 0 && ndfl != 0)
								list.Add(new FirstFunction { Surname = name, Salary = sumOklad, Premia = premia, NDFL = ndfl, toHand = sumOklad + premia - ndfl });
						}
					}
				}
			}

			ViewBag.Salary = list;
			return View();
		}

		[HttpPost]
		public RedirectResult AddNewWorker(Worker worker)
		{
			db.Workers.Add(worker);
			db.SaveChanges();
			return RedirectPermanent("/Home/Index");
		}

		[HttpGet]
		public ActionResult AddNewWorker()
		{
			return View();
		}

		[HttpPost]
		public RedirectResult AddNewPosition(Position position)
		{
			db.Positions.Add(position);
			db.SaveChanges();
			return RedirectPermanent("/Home/Index");
		}


		[HttpGet]
		public ActionResult AddNewPosition()
		{
			return View();
		}

		[HttpGet]
		public ActionResult HistoryView()
		{
			IEnumerable<History> histories = db.Histories;
			ViewBag.Histories = histories;
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		[HttpGet]
		public ActionResult AddNewHistory()
		{
			return View();
		}

		[HttpPost]
		public RedirectResult AddNewHistory(History history)
		{
			db.Histories.Add(history);
			db.SaveChanges();
			return RedirectPermanent("/Home/Index");
		}
	}
}