using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstrackts;
using Ptoject.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concrates
{
    public class BaseManager<T> : IManager<T> where T : class , IEntity  
    {
        protected IRepository<T> _iRep;

        public BaseManager(IRepository<T> iRep)
        {
            _iRep = iRep;
        }



        public void Add(T item)
        {
          _iRep.Add(item);
                     
        }

        public void AddRange(List<T> list)
        {
            
            _iRep.AddRange(list);
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {

            return _iRep.Any(exp);


        }

        public void Delete(T item)
        {
            _iRep.Delete(item);
        }

        public void DeleteRange(List<T> list)
        {
            _iRep.DeleteRange(list);
        }

        public void Destroy(T item)
        {
            _iRep.Destroy(item);
        }

        public void DestroyRange(List<T> list)
        {
            _iRep.DeleteRange(list);
        }

        public T Find(int id)
        {
            return _iRep.Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _iRep.FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return _iRep.GetActives();
        }

        public List<T> GetAll()
        {
            return _iRep.GetAll();
        }

        public List<T> GetDeleted()
        {
            return _iRep.GetDeleted();
        }

        public List<T> GetFirstDatas(int number)
        {
            return _iRep.GetFirstDatas(number);
        }

        public List<T> GetLastDatas(int number)
        {
            return _iRep.GetLastDatas(number);
        }

        public List<T> GetUpdated()
        {
            return _iRep.GetActives();
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _iRep.Select(exp);
        }

        public IQueryable<X> SelectViaClass<X>(Expression<Func<T, X>> exp)
        {
            return _iRep.SelectViaClass(exp);
        }

        public void Update(T item)
        {
            _iRep.Update(item);
        }

        public void UpdateRange(List<T> list)
        {
            _iRep.UpdateRange(list);
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _iRep.Where(exp);
        }

        
    }
}
