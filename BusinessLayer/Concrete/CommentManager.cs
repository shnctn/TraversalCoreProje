using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetList()
        {
           return _commentDal.GetList();
        }

        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public Comment TGetById(int id)
        {
           return _commentDal.GetById(id);
        }

        public void TUpdate(Comment t)
        {
           _commentDal.Update(t);
        }

        public List<Comment> TGetDestinationByID(int id)
        {
            return _commentDal.GetByListFilter(x=>x.DestinationID ==id); 
        }
    }
}
