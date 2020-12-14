using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace Sandu_Ana_alexandra_Lab10.Models
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(ShopList))]
        public int ShopListID { get; set; }
        public int ProductID { get; set; }
    }
}
