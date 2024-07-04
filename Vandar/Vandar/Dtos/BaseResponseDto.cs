namespace Vandar.Dtos;

public class BaseResponse<T>
{
    public int status { get; set; }
    public Data<T> data { get; set; }
}

public class Data<T>
{
    public T Item { get; set; }
}
