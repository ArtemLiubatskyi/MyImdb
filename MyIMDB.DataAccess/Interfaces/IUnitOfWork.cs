﻿using MyIMDB.Data.Entities;
using System.Threading.Tasks;

namespace MyIMDB.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        IUserMovieRepository UserMoviesRepository { get; }
        IMovieRepository MovieRepository { get; }
        IUserRepository UserRepository { get; }
        IMoviePersonRepository MoviePersonRepository { get; }
        IRepository<Gender> GenderRepository { get; }
        IRepository<Country> CountryRepository { get; }
        IRepository<MoviePersonType> MoviePersonTypeRepository { get; }
        IRepository<Role> RolesRepository { get; }
        IRepository<RefreshToken> TokenRepository { get; }
        IReviewRepository ReviewRepository { get; }
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        Task<int> SaveChangesAsync();
    }
}
