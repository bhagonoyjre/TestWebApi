using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Xml;
using System.Xml.Linq;

using AppLibrary.ViewModels;
using SerkoTestWebApi.Models.Inteface;

namespace SerkoTestWebApi.Models.Repositories
{

    /// <summary>
    /// 12.07.2018
    /// </summary>
    public class ExpenseClaimRepository : IRepository<ExpenseClaimVM>, IDisposable
    {

        #region " Base Methods "

        /// <summary>
        /// 12.07.2018
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ExpenseClaimVM> Get()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 12.07.2018
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ExpenseClaimVM Get(Guid id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 12.07.2018
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<ExpenseClaimVM> GetMany(Expression<Func<ExpenseClaimVM, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 12.07.2018
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public ExpenseClaimVM GetSingle(Expression<Func<ExpenseClaimVM, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 12.07.2018
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }
        

        /// <summary>
        /// 12.07.2018
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Guid Save(ExpenseClaimVM model)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 12.07.2018
        /// </summary>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public Guid ProcessXMLData(string xmlString)
        {
            return Guid.Empty;
        }

        #endregion


        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
         //~ExpenseClaimRepository() {
         //  // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
         //  Dispose(false);
         //}

        /// <summary>
        /// This code added to correctly implement the disposable pattern.
        /// </summary>
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
        
    }
}