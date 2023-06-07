﻿using Application.Commands.Brand;
using Application.DataTransfer;
using Application.DataTransfer.BrandDataTransfer;
using Application.Exceptions;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Commands.Brand
{
    public class EfRemoveBrandCommand : IRemoveBrandCommand
    {
        public int Id => 100;

        public string Name => "Removes the brand";

        private readonly Context _context;

        public EfRemoveBrandCommand(Context context)
        {
            _context = context;

        }

        public void Execute(RemoveEntityDto request)
        {
            var brand = _context.Brands.Find(request.Id);

            if (brand == null) 
            {
                throw new EntityNotFoundException(request.Id, typeof(Domain.Brand));
            }

            if (request.Hard == false)
            {
                brand.DeletedAt = DateTime.Now;
            }
            else
            {
                _context.Brands.Remove(brand);
            }

            _context.SaveChanges();
        }
    }
}
