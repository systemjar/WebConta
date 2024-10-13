﻿using WebConta.Shared.Responses;

namespace WebConta.Backend.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        //Para un objeto en especial
        Task<ActionResponse<T>> GetAsync(int id);

        //Para una lista de cualquier objeto
        Task<ActionResponse<IEnumerable<T>>> GetAsync();

        //Para edicionar una entidad
        Task<ActionResponse<T>> AddAsync(T entity);

        //Eliminar un objeto
        Task<ActionResponse<T>> DeleteAsync(int id);

        //Modificar un objeto
        Task<ActionResponse<T>> UpdateAsync(T entity);
    }
}