﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsletterService
    {
        INewsletterDal _newsletterDal;

        public NewsLetterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public List<Newsletter> GetList()
        {
            return _newsletterDal.GetList();
        }

        public void TAdd(Newsletter t)
        {
            _newsletterDal.Insert(t);   
        }

        public void TDelete(Newsletter t)
        {
            _newsletterDal.Delete(t);
        }

        public Newsletter TGetById(int id)
        {
           return _newsletterDal.GetById(id);
        }

        public void TUpdate(Newsletter t)
        {
           _newsletterDal.Update(t);    
        }
    }
}
