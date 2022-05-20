using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.DTOs;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapContext>, ICarDal
    {
        List<CarDetailDto> ICarDal.GetCarDetails()
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
/*
        FROM student
        JOIN student_course
        ON student.id = student_course.student_id
        OIN course
        ON course.id = student_course.course_id;
*/