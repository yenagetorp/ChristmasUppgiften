using Christmas.Models.Entities;
using Christmas.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Christmas.Models
{
    public class ChristmasPresentsService
    {
        GiftsContext context;
        public ChristmasPresentsService(GiftsContext context)
        {
            this.context = context;
        }

        public ChristmasIndexVM GetAllPeople()
        {
            return new ChristmasIndexVM
            {
                People = context.Person
                .Select(p => new ChristmasIndexItemVM
                {
                    Id=p.Id,
                    Name=p.Name,
                    Rhymes=p.Present.Where(ps=>ps.RecieverId==p.Id)
                    .Select(ps=>ps.Rhyme).ToList()
                    //.SingleOrDefault(ps=>ps.RecieverId==p.Id).Rhyme
                })
                 .ToArray()
            };


        }

        public void AddAPerson(ChristmasPeopleCreateVM person)
        {
            context.Person.Add(new Person
            {
                Name = person.Name
            });
            context.SaveChanges();
        }

        public void CreatePresents(ChristmasPresentsCreateVM present)
        {
            context.Present.Add(new Present
            {
                Rhyme = present.Rhyme,
                Reciever = this.context.Person.SingleOrDefault(p=>p.Id==present.RecieverId)
            });
            context.SaveChanges();
        }
    }
}
