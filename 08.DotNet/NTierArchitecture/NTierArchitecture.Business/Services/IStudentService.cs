﻿using NTierArchitecture.Entities.DTOs;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Services;
public interface IStudentService
{
    string Create(CreateStudentDto request);

    string Update(UpdateStudentDto request);
    string DeleteById(Guid id);
    List<Student> GetAll();
}