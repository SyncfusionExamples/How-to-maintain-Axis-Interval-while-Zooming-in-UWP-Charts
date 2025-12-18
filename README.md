# How to maintain axis interval while zooming in UWP Charts?
This sample demonstrate how to maintain a particular interval on axes while zooming UWP chart.

**Step 1**: Initialize the [ChartZoomPanBehavior](https://help.syncfusion.com/uwp/charts/interactive-features#zoom-and-pan) in the [SfChart](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.Charts.SfChart.html)’s Behaviors collection to enable zoom and pan behavior.
```xml
<chart:SfChart>
. . .
    <chart:SfChart.Behaviors>
        <chart:ChartZoomPanBehavior />
    </chart:SfChart.Behaviors>
. . .
</chart:SfChart>
```

**Step 2**: On the Chart Axis, set the [EnableAutoIntervalOnZooming](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.Charts.ChartAxis.html#Syncfusion_UI_Xaml_Charts_ChartAxis_EnableAutoIntervalOnZooming) property to `False`, and specify a fixed [Interval](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.Charts.NumericalAxis.html#Syncfusion_UI_Xaml_Charts_NumericalAxis_Interval) value. This interval will remain constant during all zoom operations.
```xml
<chart:SfChart>
     . . .
    <chart:SfChart.PrimaryAxis>
        <chart:NumericalAxis Interval="5" EnableAutoIntervalOnZooming="False" />
    </chart:SfChart.PrimaryAxis>
 
    <chart:SfChart.SecondaryAxis>
        <chart:NumericalAxis />
    </chart:SfChart.SecondaryAxis>
 
    <chart:ColumnSeries ItemsSource="{Binding Data}"
                        XBindingPath="XValue"
                        YBindingPath="YValue" />
</chart:SfChart>
```

### Output
A UWP Chart displaying data with an X-axis interval of 5 and a Y-axis interval of 20 before any zooming.

After zooming, the X-axis continues to display labels with an interval of 5 because of disabling auto interval on zooming. Concurrently, the Y-axis's interval is shown dynamically adjusted to the new zoom level.
![zooming](https://github.com/user-attachments/assets/ed0f7b83-67ef-402f-b9cd-01c8081f7852)

## Troubleshooting

### Path Too Long Exception

If you are facing a "Path too long" exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

Refer to the Knowledge Base article [How to maintain axis interval while zooming in UWP Charts]().
