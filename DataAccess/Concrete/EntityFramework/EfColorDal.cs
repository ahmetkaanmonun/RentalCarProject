﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (RentalCarDbContext context = new RentalCarDbContext())
            {

                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Color entity)
        {
            using (RentalCarDbContext context = new RentalCarDbContext())
            {

                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

      

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (RentalCarDbContext context = new RentalCarDbContext())
            {

                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();

            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (RentalCarDbContext context = new RentalCarDbContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);

            }
        }

        public void Update(Color entity)
        {
            using (RentalCarDbContext context = new RentalCarDbContext())
            {

                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
