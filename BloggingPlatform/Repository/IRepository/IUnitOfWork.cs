﻿namespace BloggingPlatform.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IPostRepository Post { get;  }
        void Save();
    }
}
