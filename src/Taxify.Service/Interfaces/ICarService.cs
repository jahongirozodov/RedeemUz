﻿using Taxify.Domain.Configuration;
using Taxify.Service.DTOs.Cars;

namespace Taxify.Service.Interfaces;

public interface ICarService
{
    ValueTask<CarResultDto> AddAsync(CarCreationDto dto);
    ValueTask<CarResultDto> ModifyAsync(CarUpdateDto dto);
    ValueTask<bool> RemoveAsync(long id);
    ValueTask<bool> DestroyAsync(long id);
    ValueTask<CarResultDto> RetrieveByIdAsync(long id);
    ValueTask<IEnumerable<CarResultDto>> RetrieveAllAsync(PaginationParams @params);
}