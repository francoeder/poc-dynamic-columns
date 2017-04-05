using POC.DynamicColumns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POC.DynamicColumns.Controllers
{
    public class ColunasDinamicasController : Controller
    {
        // GET: ColunasDinamicas
        public ActionResult Index()
        {
            var model = new List<Column>();
            model.Add(GetColumn1());
            model.Add(GetColumn2());
            model.Add(GetColumn3());

            return View(model);
        }

        public Column GetColumn1()
        {
            var modelItem = new Column();
            modelItem.Name = "Nome";
            modelItem.Rows = new List<Row>();
            modelItem.Rows.Add(new Row { Line = 1, Value = "Batman" });
            modelItem.Rows.Add(new Row { Line = 2, Value = "SuperMan" });
            modelItem.Rows.Add(new Row { Line = 3, Value = "MulherMaravilha" });
            modelItem.Rows.Add(new Row { Line = 4, Value = "Flash" });
            modelItem.Rows.Add(new Row { Line = 5, Value = "AquaMan" });

            return modelItem;
        }

        public Column GetColumn2()
        {
            var modelItem = new Column();
            modelItem.Name = "Sexo";
            modelItem.Rows = new List<Row>();
            modelItem.Rows.Add(new Row { Line = 1, Value = "Masculino" });
            modelItem.Rows.Add(new Row { Line = 2, Value = "Masculino" });
            modelItem.Rows.Add(new Row { Line = 3, Value = "Feminino" });
            modelItem.Rows.Add(new Row { Line = 4, Value = "Masculino" });
            modelItem.Rows.Add(new Row { Line = 5, Value = "Feminino" });

            return modelItem;
        }

        public Column GetColumn3()
        {
            var modelItem = new Column();
            modelItem.Name = "Idade";
            modelItem.Rows = new List<Row>();
            modelItem.Rows.Add(new Row { Line = 1, Value = "32" });
            modelItem.Rows.Add(new Row { Line = 2, Value = "44" });
            modelItem.Rows.Add(new Row { Line = 3, Value = "29" });
            modelItem.Rows.Add(new Row { Line = 4, Value = "19" });
            modelItem.Rows.Add(new Row { Line = 5, Value = "30" });

            return modelItem;
        }
    }
}