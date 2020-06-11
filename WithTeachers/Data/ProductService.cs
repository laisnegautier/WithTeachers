using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WithTeachers.Data
{
    public class ProductService
    {

        //private ApplicationDbContext _context;


        //public ProductService(ApplicationDbContext context)
        //{
        //    _context = context;
        //}



        #region Public methods

        /// <summary>
        /// This method returns the list of product
        /// </summary>
        /// <returns></returns>
        //public async Task<List<Product>> GetProductAsync() => await _context.Product.ToListAsync();

        /// <summary>
        /// This method add a new product to the DbContext and saves it
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        //public async Task<Product> AddProductAsync(Product product)
        //{
        //    try
        //    {
        //        _context.Product.Add(product);
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return product;
        //}

        /// <summary>
        /// This method update and existing product and saves the changes
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        //public async Task<Product> UpdateProductAsync(Product product)
        //{
        //    try
        //    {
        //        var productExist = _context.Product.FirstOrDefault(p => p.Id == product.Id);
        //        if (productExist != null)
        //        {
        //            _context.Update(product);
        //            await _context.SaveChangesAsync();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return product;
        //}

        /// <summary>
        /// This method removes and existing product from the DbContext and saves it
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        //public async Task DeleteProductAsync(Product product)
        //{
        //    try
        //    {
        //        _context.Product.Remove(product);
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        #endregion Public methods
    }
}