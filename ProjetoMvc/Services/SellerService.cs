using ProjetoMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoMvc.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace ProjetoMvc.Services
{
    public class SellerService
    {
        private readonly ProjetoMvcContext _context;
        
        public SellerService(ProjetoMvcContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
           
        }

        
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        internal void Remove(Seller seller)
        {
            throw new NotImplementedException();
        }

        public void Update(Seller obj)
        {
            if (!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundExeception("ID NOT FOUND");
            }
            try { 
            _context.Update(obj);
            _context.SaveChanges();
            }
           catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
        
    }
}
