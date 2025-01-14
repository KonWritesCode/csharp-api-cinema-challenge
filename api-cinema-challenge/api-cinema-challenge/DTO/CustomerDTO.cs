﻿using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class CustomerDTO : BaseDTO
    {
        public CustomerDTO(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;
            CreatedAt = customer.CreatedAt;
            UpdatedAt = customer.UpdatedAt;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
