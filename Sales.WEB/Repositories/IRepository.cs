namespace Sales.WEB.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T model);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T model);
        Task<HttpResponseWrapper<Object>> Delete(string url);
        Task<HttpResponseWrapper<Object>> Put<T>(string url, T model);
        Task<HttpResponseWrapper<TResponse>> Put<T, TResponse>(string url, T model);
    }

}
}