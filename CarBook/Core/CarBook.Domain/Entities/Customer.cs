﻿namespace CarBook.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public List<RentACarProcess> RentACarProcesses { get; set; }
    }
}