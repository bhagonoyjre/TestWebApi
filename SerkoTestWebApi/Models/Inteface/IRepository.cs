using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SerkoTestWebApi.Models.Inteface
{
    /// <summary>
    /// 12.07.2018
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// 12.07.2018
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> Get();

        /// <summary>
        /// 12.07.2018
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IEnumerable<T> GetMany(Expression<Func<T, bool>> predicate = null);

        /// <summary>
        /// 12.07.2018
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(Guid id);

        /// <summary>
        /// 12.07.2018
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        T GetSingle(Expression<Func<T, bool>> predicate = null);

        /// <summary>
        /// 12.07.2018
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Guid Save(T model);

        /// <summary>
        /// 12.07.2018
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Remove(Guid id);

        /// <summary>
        /// 12.07.2018
        /// </summary>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        Guid ProcessXMLData(string xmlString);
    }
}
