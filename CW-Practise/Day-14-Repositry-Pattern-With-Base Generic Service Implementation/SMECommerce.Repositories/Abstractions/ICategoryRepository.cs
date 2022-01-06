using SMECommerce.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMECommerce.Repositories.Abstractions
{
   public  interface ICategoryRepository : IRepository<Category>
    {
        bool isValid(); //Umcommon Methdod where it does'nt contain in base interface

        Category CategoryName(int id);
       
    }



}
