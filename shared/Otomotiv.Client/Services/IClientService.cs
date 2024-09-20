using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.Client.Services
{
    public interface IClientService<T, E>
    {
        Task<E> RestClientPostAsync(string baseUrl, string url, T requestObject);
        Task<E> RestClientGetAsync(string url, T requestObject);

    }
}
