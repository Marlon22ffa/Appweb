using System.Collections.Generic;
using System.Threading.Tasks;
using ApiProductos.Models;

namespace Apiproductos.Repositories
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetProductos();
        Task<Producto> GetProductoById(int id);
        Task<Producto> AddProducto(Producto producto);
        Task<Producto> UpdateProducto(Producto producto);
        Task<bool> DeleteProducto(int id);
    }
}