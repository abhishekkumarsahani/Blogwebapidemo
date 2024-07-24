using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UnitOfWork : IUnitOfWork
    {
        //for jwt token
       
        private IConfiguration _config { get; }
        public UnitOfWork(IConfiguration config)
        {
            _config = config;
        }
        //initialize service to get access method
        public BlogService blogservice => new BlogService();
    }

}
