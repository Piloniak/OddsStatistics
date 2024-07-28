using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Kursy_Betclic.Models
{
    class Fighter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        ObservableCollection<Fight> Fights { get; set; }
    }
    class DBFighterClass
    {
        [PrimaryKey, AutoIncrement, SQLite.Column("Id")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
