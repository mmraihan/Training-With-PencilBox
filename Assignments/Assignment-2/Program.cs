using Assignment_2.Models;
using System;
using System.Collections.Generic;
using Type = Assignment_2.Models.Type;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Type List

            List<Type> types = new List<Type>()
            {
                new Type(){ Id = 1, Name = "Wipes"},
                new Type(){ Id = 2, Name = "Diapers"},
            };


            #endregion

            #region SubCategoryList
            SubCategory subCategory1 = new SubCategory() { Id = 1, Name = "Diapers & Wipes",};
           


            #endregion

            #region Category
            Category category1 = new Category() { Id = 1, Name = "Baby Care", };
            Category category2 = new Category() { Id = 2, Name = "Baby Care2" };
            Category category3 = new Category() { Id = 3, Name = "Baby Care3" };
            Category category4= new Category() { Id = 4, Name = "Baby Care4" };

            #endregion

           
        }
    }
}
