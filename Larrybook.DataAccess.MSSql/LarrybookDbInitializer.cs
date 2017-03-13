using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larrybook.DataAccess.MSSql
{
    class LarrybookDbInitializer : DropCreateDatabaseAlways<LarrybookContext>
    {
        protected override void Seed(LarrybookContext context)
        {
            context.Kategorien.Add(new Kategorie() { Name = "Kateg1" });
            context.Kategorien.Add(new Kategorie() { Name = "Kateg324" });
            context.Kategorien.Add(new Kategorie() { Name = "Kategorie2345" });
            context.Kategorien.Add(new Kategorie() { Name = "Kategor324" });
            context.Kategorien.Add(new Kategorie() { Name = "Kategorie6432" });
            context.Kategorien.Add(new Kategorie() { Name = "Katego34c" });
            context.Kategorien.Add(new Kategorie() { Name = "Katego87z" });

            var dateToday = DateTime.Now;
            context.Transaktionen.Add(new Transaktion()
            {
                Beschreibung = "fdshabhhvxy asrvs <vfafds",
                Betrag = 11.88m,
                Datum = dateToday,
                IsEinnahme = true,
                Kategorie = context.Kategorien.Add(new Kategorie()
                {
                    Name = "mdsaasuuc"
                })
            });
            context.Transaktionen.Add(new Transaktion()
            {
                Beschreibung = "fdshabhhvxy asrvs <vfafds",
                Betrag = 32.45m,
                Datum = dateToday.AddDays(-5),
                IsEinnahme = false,
                Kategorie = context.Kategorien.Add(new Kategorie()
                {
                    Name = "23f"
                })
            });
            context.Transaktionen.Add(new Transaktion()
            {
                Beschreibung = "fdsh <vfafds",
                Betrag = 24.56m,
                Datum = dateToday.AddDays(-4),
                IsEinnahme = true,
                Kategorie = context.Kategorien.Add(new Kategorie()
                {
                    Name = "azusdbf"
                })
            });
            context.Transaktionen.Add(new Transaktion()
            {
                Beschreibung = "fdshabhhvxy asrvs <vfafds",
                Betrag = 255,
                Datum = dateToday.AddDays(-1),
                IsEinnahme = false,
                Kategorie = context.Kategorien.Add(new Kategorie()
                {
                    Name = "pffsa"
                })
            });
            context.Transaktionen.Add(new Transaktion()
            {
                Beschreibung = "fdshabhhvxy asrvs <vfafds",
                Betrag = 13,
                Datum = dateToday.AddDays(-2),
                IsEinnahme = false,
                Kategorie = context.Kategorien.Add(new Kategorie()
                {
                    Name = "asfzv"
                })
            });
            context.Transaktionen.Add(new Transaktion()
            {
                Beschreibung = "fdshabhhvxy asrvs <vfafds",
                Betrag = 5,
                Datum = dateToday.AddDays(-1),
                IsEinnahme = false,
                Kategorie = context.Kategorien.Add(new Kategorie()
                {
                    Name = "sabhzjusa"
                })
            });

            base.Seed(context);
        }
    }
}
