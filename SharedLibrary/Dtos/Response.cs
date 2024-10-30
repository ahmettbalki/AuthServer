using System.Text.Json.Serialization;

namespace SharedLibrary.Dtos;
public class Response<T> where T : class
{
    public T Data { get; set; }
    public int StatusCode { get; set; }
    [JsonIgnore]public bool IsSuccessful { get; set; }
    public ErrorDto Error { get; set; }
    public static Response<T> Success(T data, int StatusCode)
    {
        return new Response<T> { Data = data, StatusCode = StatusCode, IsSuccessful = true };
    }
    public static Response<T> Success(int statusCode)
    {
        return new Response<T> { Data = default, StatusCode = statusCode, IsSuccessful = true };
    }
    public static Response<T> Fail(ErrorDto errorDto, int StatusCode)
    {
        return new Response<T> { Error = errorDto, StatusCode = StatusCode, IsSuccessful = false };
    }
    public static Response<T> Fail(string errorMessage, int StatusCode, bool isShow)
    {
        var errorDto = new ErrorDto(errorMessage, isShow);
        return new Response<T> {Error = errorDto, StatusCode = StatusCode, IsSuccessful = false };
    }
}
