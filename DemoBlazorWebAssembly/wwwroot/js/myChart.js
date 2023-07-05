function createChart() {
    var data = {
        // A labels array that can contain any sort of values
        labels: ['Mon', 'Tue', 'Wed', 'Thu', 'Fri'],
        // Our series array that contains series objects or in this case series data arrays
        series: [
            [5, 2, 4, 2, 0]
        ]
    };

    // Create a new line chart object where as first parameter we pass in a selector
    // that is resolving to our chart container element. The Second parameter
    // is the actual data object.
    new Chartist.Line('.ct-chart', data);
}

function createChart2(elemento) {
    var data = {
        // A labels array that can contain any sort of values
        labels: ['Mon', 'Tue', 'Wed', 'Thu', 'Fri'],
        // Our series array that contains series objects or in this case series data arrays
        series: [
            [5, 2, 4, 2, 0]
        ]
    };
    new Chartist.Line(elemento, data);
}

function createChart3(elemento, data) {
    new Chartist.Line(elemento, data);
}

function createChart4(elemento, data, type) {
    if (type === 'Line') {
      elemento.chart =  new Chartist.Line(elemento, data);
    }
    else {
      elemento.chart =  new Chartist.Bar(elemento, data);
    }
}

function updateChart(elemento, data) {
    elemento.chart.update(data);
};
