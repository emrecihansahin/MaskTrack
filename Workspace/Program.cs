// See https://aka.ms/new-console-template for more information
using Bussiness.Concrete;
using Entities.Concretre;

Person person1 = new Person();
person1.Name = "Emre Cihan";
person1.Surname = "Şahin";
person1.NationalId = 32632880798;
person1.BirthYear = 1993;

PttManager pttManager = new PttManager(new ForeignerManager());

pttManager.GiveMask(person1);