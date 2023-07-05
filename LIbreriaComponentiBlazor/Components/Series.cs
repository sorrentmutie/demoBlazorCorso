
using LIbreriaComponentiBlazor.Models;
using Microsoft.AspNetCore.Components;

namespace LIbreriaComponentiBlazor.Components;

public class Series : ComponentBase, IDisposable
{
    [Parameter] public List<double> Values { get; set; }
    [CascadingParameter] public Chart MyChart { get; set; }

    private readonly SeriesData _seriesData = new();
    protected override void OnParametersSet()
    {
        _seriesData.Data = Values;
    }

    protected override void OnInitialized()
    {
        if(MyChart.ChartData.Series == null)
        {
            MyChart.ChartData.Series = new List<SeriesData>();   
        }
        MyChart.ChartData.Series.Add(_seriesData);
    }

    public void Dispose()
    {
        if(_seriesData !=  null)
        {
            MyChart.ChartData.Series.Remove(_seriesData);
        }
    }
}
