using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SignUp.Models;

namespace SignUp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        { 
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SignUpContext>();
                {
                    context.Database.EnsureCreated();

                    if (!context.Person.Any())
                    {
                        context.Person.AddRange(new List<Person>()
                        {
                            new Person()
                            {
                                PersonName="unassigned",
                                Email="none",
                                PhoneNumber="none",
                                
                            }
                        });
                        context.SaveChanges();
                    }

                    
                }
            }
        }
    }
}
