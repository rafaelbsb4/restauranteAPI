using ProjetoNovo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoNovo.Repository
{
    public class BaseRepository 
    {
        protected static DataContext db = new DataContext();
    }
}