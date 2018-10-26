﻿using Academy.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mapster;
using System.Threading.Tasks;

namespace Academy.Application
{
    public class CourseCategoryService : ICourseCategoryService
    {
        private ICourseCategoryRepository _repository;
        public CourseCategoryService(ICourseCategoryRepository repository)
        {
            this._repository = repository;
        }
        public void Create(CreateCourseCategoryDTO dto)
        {
            var courseCategory = new CourseCategory()
            {
                Title = dto.Title
            };
            _repository.Add(courseCategory);
        }

        public void Update(ModifyCourseCategoryDTO dto)
        {
            var courseCategory = _repository.GetById(dto.Id);
            courseCategory.Title = dto.Title;
            _repository.Update(courseCategory);
        }

        public async Task<List<CourseCategoryDTO>> GetAll()
        {
            var data =  await _repository.GetAll();
            return data.Adapt<List<CourseCategoryDTO>>();
        }

        public void Delete(long id)
        {
            var item = _repository.GetById(id);
            if (item != null)
                _repository.Delete(item);
        }
    }
}
