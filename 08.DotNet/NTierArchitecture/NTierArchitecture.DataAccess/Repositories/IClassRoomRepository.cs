﻿using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Repositories;

public interface IClassRoomRepository
{
    void Create(ClassRoom student);
    void Update(ClassRoom student);
    void DeleteById(Guid id);
    List<ClassRoom> GetAll();
    ClassRoom? GetClassRoomById(Guid studentId);
}
