﻿using DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDataAccess
    {
        public void CreateStackTable();
        public void CreateFlashcardTable();
        public void CreateStudyTable();
        void AddFlashcard(string? question, string? answer);
        List<DtoStack> GetListOfStackNames();
        void AddStack(string? stackName);
        List <DtoStack> GetAllStacks();
    }
}
