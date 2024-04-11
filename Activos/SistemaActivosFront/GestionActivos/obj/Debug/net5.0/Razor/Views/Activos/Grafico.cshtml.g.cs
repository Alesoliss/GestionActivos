#pragma checksum "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Grafico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20297d8668468e2f1441d0bf6555ee5fd2bf73d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activos_Grafico), @"mvc.1.0.view", @"/Views/Activos/Grafico.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\_ViewImports.cshtml"
using GestionActivos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\_ViewImports.cshtml"
using GestionActivos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20297d8668468e2f1441d0bf6555ee5fd2bf73d2", @"/Views/Activos/Grafico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06ccbeb79ff2b4b65a11fbe06774575f7ba5dbea", @"/Views/_ViewImports.cshtml")]
    public class Views_Activos_Grafico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LAB2\Desktop\Activos\Activos\SistemaActivosFront\GestionActivos\Views\Activos\Grafico.cshtml"
  
    ViewData["Title"] = "Grafico";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    body {
        font-family: Arial, sans-serif;
    }

    .chart {
        width: 800px;
        margin: 50px auto;
    }

    .line {
        fill: none;
        stroke: steelblue;
        stroke-width: 2px;
    }

    .area {
        fill: lightsteelblue;
    }

    .axis-label {
        font-size: 14px;
    }

    .axis path,
    .axis line {
        fill: none;
        stroke: #000;
        shape-rendering: crispEdges;
    }

    .axis text {
        font-size: 12px;
    }
</style>


");
            WriteLiteral(@"
<style>

    .card-title {
        font-size: 1.25rem;
        margin-bottom: 0.5rem;
    }

    svg {
        font-family: Arial, sans-serif;
    }

    .axis path,
    .axis line {
        fill: none;
        stroke: #000;
        shape-rendering: crispEdges;
    }

    .axis text {
        font-size: 12px;
    }

    .line {
        fill: none;
        stroke: #042444;
        stroke-width: 2px;
    }

    .line-chart-container {
        max-width: 100%;
        overflow-x: auto;
    }
</style>

<div class=""card-body"" style=""max-width:100%; background-color:white"">
    <div class=""row"">
        <div class=""col-md-4"">
            <h5 class=""card-title""> Total de Adquisiciones por Año</h5>
            <div id=""line-chart""></div>
        </div>
        <div class=""col-md-4"">
            <h5 class=""card-title""> Total de Adquisiciones por Año</h5>
            <div class=""chart""></div>

        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-6"" ");
            WriteLiteral(@"style=""max-width: 50%;"">
            <h5 class=""card-title"">Cantidad de Activos por Categoria</h5>
            <div class=""bar-chart"" style=""max-width: 100%;"">
                <div id=""grafico-container"">
                    <svg id=""grafico"">
                        <g class=""background-lines""></g>
                        <g class=""left-percent-labels""></g>
                        <g class=""bars""></g>
                        <g class=""bar-labels""></g>
                        <g class=""percent-labels""></g>
                        <g class=""lines""></g>
                    </svg>
                </div>
                <div id=""table-container"">
                    <table>
                        <thead>
                            <tr>
                                <th></th>
                                <th>Cantidad</th>
                            </tr>
                        </thead>
                        <tbody id=""table-body""></tbody>
                    </table>
             ");
            WriteLiteral(@"   </div>
            </div>
        </div>
    </div>
</div>




<style>


    .background-lines {
        position: absolute;
        width: 100%;
        height: 100%;
        pointer-events: none;
    }

    .card:hover {
        transform: translateY(-5px);
    }

    .bar-chart {
        display: flex;
        flex-direction: row;
        height: 400px;
    }

    #grafico-container {
        flex: 1;
        position: relative;
    }

    .bar {
        fill: #ea8e45;
        transition: height 0.5s ease-out;
    }

        .bar:hover {
            fill: #ea8e45;
        }

    .axis-x path,
    .axis-y path {
        fill: none;
        stroke: #000;
        shape-rendering: crispEdges;
    }

    .axis-x text,
    .axis-y text {
        font-size: 12px;
        font-family: sans-serif;
    }

    .bar-label {
        font-size: 10px;
        text-anchor: middle;
        fill: #333;
    }

    .percent-label {
        font-size: 10px;
   ");
            WriteLiteral(@"     text-anchor: end;
        fill: #333;
    }

    .line {
        fill: none;
        stroke: #042444;
        stroke-width: 0.5px;
    }

    .background-lines {
        position: absolute;
        width: 100%;
        height: 100%;
        pointer-events: none;
    }

    /* Styling for the table container */
    #table-container {
        display: flex;
        flex-direction: column;
        justify-content: space-between;
    }

    table {
        width: 100%;
        border-collapse: collapse;
    }

    th,
    td {
        border: 1px solid #ccc;
        padding: 5px;
        text-align: left;
    }

    th {
        background-color: #f2f2f2;
        font-weight: bold;
    }

    /* Added styles for left percentage labels */
    .left-percent-labels {
        display: flex;
        flex-direction: column;
    }

    .left-percent-label {
        font-size: 10px;
        text-anchor: end;
        fill: #333;
    }
</style>

<script src=""https:");
            WriteLiteral(@"//d3js.org/d3.v7.min.js""></script>


<script>
    var width = 700;
    var height = 350;
    var margin = { top: 20, right: 20, bottom: 50, left: 60 }; 


    var x = d3.scaleBand()
        .range([margin.left, width - margin.right])
        .padding(0.1);

    var y = d3.scaleLinear()
        .range([height - margin.bottom, margin.top]);

    // SVG
    var svg = d3.select(""#grafico"")
        .attr(""width"", width)
        .attr(""height"", height);

    //  ejes
    var xAxis = g => g
        .attr(""class"", ""axis-x"")
        .attr(""transform"", `translate(0,${height - margin.bottom})`)
        .call(g => g.selectAll("".tick line"").remove())
        .call(g => g.selectAll("".domain"").remove())
        .call(g => g.selectAll("".tick text"")
            .attr(""transform"", ""rotate(0)"")
            .attr(""x"", 0)
            .attr(""y"", 15)
            .style(""text-anchor"", ""start""));

    var yAxis = g => g
        .attr(""class"", ""axis-y"")
        .attr(""transform"", `translate(${margin.");
            WriteLiteral(@"left},0)`);

    fetch('https://localhost:44311/API/Activo/ListadoDashboard')
        .then(response => response.json())
        .then(data => {
            var dataFromAPI = data.data.map(item => ({
                Categoria: item.cate_Descripcion,
                Porcentaje: item.porcentajeActivos,
                Cantidad: item.cantidadActivos
            }));

            var maxPercentage = d3.max(dataFromAPI, d => d.Porcentaje);

            var percentageLabels = [];
            for (var i = 0; i <= maxPercentage; i += 10) {
                percentageLabels.push(i);
            }

            x.domain(dataFromAPI.map(d => d.Categoria));

            y.domain([0, maxPercentage]);

            var bars = svg.select("".bars"")
                .selectAll("".bar"")
                .data(dataFromAPI)
                .enter().append(""rect"")
                .attr(""class"", ""bar"")
                .attr(""x"", d => x(d.Categoria))
                .attr(""y"", height - margin.bottom) 
        ");
            WriteLiteral(@"        .attr(""width"", x.bandwidth())
                .attr(""height"", 0) 
                .transition() 
                .duration(500) 
                .delay((d, i) => i * 100) 
                .attr(""y"", d => y(d.Porcentaje))
                .attr(""height"", d => height - margin.bottom - y(d.Porcentaje));

            svg.select("".bar-labels"")
                .selectAll("".bar-label"")
                .data(dataFromAPI)
                .enter().append(""text"")
                .attr(""class"", ""bar-label"")
                .attr(""x"", d => x(d.Categoria) + x.bandwidth() / 2)
                .attr(""y"", height - margin.bottom + 15) 
                .text(d => d.Categoria);

          
            svg.select("".percent-labels"")
                .selectAll("".percent-label"")
                .data(dataFromAPI)
                .enter().append(""text"")
                .attr(""class"", ""percent-label"")
                .attr(""x"", d => x(d.Categoria) + x.bandwidth() / 2)
                .attr(""y"", d => y(d.");
            WriteLiteral(@"Porcentaje) - 5)
                .text(d => d.Porcentaje + ""%"");

            svg.select("".lines"")
                .selectAll("".line"")
                .data(dataFromAPI)
                .enter().append(""line"")
                .attr(""class"", ""line"")
                .attr(""x1"", margin.left)
                .attr(""y1"", d => y(d.Porcentaje))
                .attr(""x2"", width - margin.right)
                .attr(""y2"", d => y(d.Porcentaje))
                .attr(""stroke-dasharray"", ""5,5""); 
            var leftPercentLines = svg.select("".left-percent-lines"")
                .selectAll("".left-percent-line"")
                .data(percentageLabels)
                .enter().append(""line"")
                .attr(""class"", ""left-percent-line"")
                .attr(""x1"", margin.left)
                .attr(""y1"", d => y(d))
                .attr(""x2"", width - margin.right)
                .attr(""y2"", d => y(d))
                .attr(""stroke-dasharray"", ""5,5"")
                .attr(""stroke"", ""#ccc"");
");
            WriteLiteral(@"
            var leftPercentLabels = svg.select("".left-percent-labels"");
            leftPercentLabels.selectAll("".left-percent-label"")
                .data(percentageLabels)
                .enter().append(""text"")
                .attr(""class"", ""left-percent-label"")
                .attr(""x"", margin.left - 10)
                .attr(""y"", d => y(d) - 3)
                .text(d => d + ""%"");

            leftPercentLines.raise();

            svg.append(""g"").call(xAxis);
            svg.append(""g"").call(yAxis);

            var tableBody = d3.select(""#table-body"");
            dataFromAPI.forEach(item => {
                var row = tableBody.append(""tr"");
                row.append(""td"").text(item.Categoria);
                row.append(""td"").text(item.Cantidad);
            });
        })
        .catch(error => {
            console.error('Error fetching data:', error);
        });
</script>




");
            WriteLiteral(@"
<script>
    var lineChartWidth = 400;
    var lineChartHeight = 250;
    var lineChartMargin = { top: 20, right: 20, bottom: 50, left: 60 };

    var lineSvg = d3.select(""#line-chart"")
        .append(""svg"")
        .attr(""width"", lineChartWidth)
        .attr(""height"", lineChartHeight);

    var xLineScale = d3.scaleBand()
        .range([lineChartMargin.left, lineChartWidth - lineChartMargin.right])
        .padding(0.1);

    var yLineScale = d3.scaleLinear()
        .range([lineChartHeight - lineChartMargin.bottom, lineChartMargin.top]);

    var xAxisLine = g => g
        .attr(""class"", ""axis axis-x"")
        .attr(""transform"", `translate(0,${lineChartHeight - lineChartMargin.bottom})`)
        .call(d3.axisBottom(xLineScale));

    var yAxisLine = g => g
        .attr(""class"", ""axis axis-y"")
        .attr(""transform"", `translate(${lineChartMargin.left},0)`)
        .call(d3.axisLeft(yLineScale));

    fetch('https://localhost:44311/API/Activo/ListadoPFecha')
        .then(");
            WriteLiteral(@"response => response.json())
        .then(data => {
            var dataFromAPI = data.data;
            xLineScale.domain(dataFromAPI.map(d => d.anio));
            yLineScale.domain([0, d3.max(dataFromAPI, d => d.totalAdquisiciones)]);

            var line = d3.line()
                .x(d => xLineScale(d.anio) + xLineScale.bandwidth() / 2)
                .y(d => yLineScale(d.totalAdquisiciones));

            lineSvg.append(""g"")
                .call(xAxisLine);

            lineSvg.append(""g"")
                .call(yAxisLine);

            lineSvg.append(""path"")
                .datum(dataFromAPI)
                .attr(""class"", ""line"")
                .attr(""d"", line);

            // xxxxxxxx x
            lineSvg.append(""text"")
                .attr(""class"", ""axis-label"")
                .attr(""transform"", `translate(${lineChartWidth / 2},${lineChartHeight - 10})`)
                .style(""text-anchor"", ""middle"")
                .text(""Año"");

            // yyyyyyyyy y
   ");
            WriteLiteral(@"         lineSvg.append(""text"")
                .attr(""class"", ""axis-label"")
                .attr(""transform"", ""rotate(-90)"")
                .attr(""y"", 0 - lineChartMargin.left)
                .attr(""x"", 0 - (lineChartHeight / 2))
                .attr(""dy"", ""1em"")
                .style(""text-anchor"", ""middle"")
                .text(""Total de Adquisiciones"");
        })
        .catch(error => {
            console.error('Error fetching data:', error);
        });
</script>


");
            WriteLiteral(@"
<script>
    fetch('https://localhost:44311/API/Activo/ListadoPrecio')
        .then(response => response.json())
        .then(data => {
            // MAPEOO depreciación
            const depreciationValues = data.map(d => parseFloat(d.totalCostoDepreciable));

           
            const margin = { top: 20, right: 20, bottom: 50, left: 50 };
            const width = 800 - margin.left - margin.right;
            const height = 400 - margin.top - margin.bottom;

            //  XXXXXXXXXXXXX
            const xScale = d3.scaleLinear()
                .domain([0, depreciationValues.length - 1])
                .range([0, width]);

            // YYYYYYYYYYY Y
            const yScale = d3.scaleLinear()
                .domain([0, d3.max(depreciationValues)])
                .range([height, 0]);

           
            const area = d3.area()
                .x((d, i) => xScale(i))
                .y0(height)
                .y1(d => yScale(d));

            // Línea
        ");
            WriteLiteral(@"    const line = d3.line()
                .x((d, i) => xScale(i))
                .y(d => yScale(d));

            // SVG
            const svg = d3.select('.chart')
                .append('svg')
                .attr('width', width + margin.left + margin.right)
                .attr('height', height + margin.top + margin.bottom)
                .append('g')
                .attr('transform', `translate(${margin.left}, ${margin.top})`);

            svg.append('path')
                .datum(depreciationValues)
                .attr('class', 'area')
                .attr('d', area);

            svg.append('path')
                .datum(depreciationValues)
                .attr('class', 'line')
                .attr('d', line);

            const xAxis = d3.axisBottom(xScale);
            const yAxis = d3.axisLeft(yScale);

            svg.append('g')
                .attr('class', 'axis')
                .attr('transform', `translate(0, ${height})`)
                .call(xAxis);");
            WriteLiteral(@"

            svg.append('g')
                .attr('class', 'axis')
                .call(yAxis);

            svg.append('text')
                .attr('class', 'axis-label')
                .attr('text-anchor', 'middle')
                .attr('transform', `translate(${width / 2}, ${height + margin.bottom - 10})`)
                .text('Número de Activo');

            svg.append('text')
                .attr('class', 'axis-label')
                .attr('text-anchor', 'middle')
                .attr('transform', `translate(${-margin.left + 20}, ${height / 2}) rotate(-90)`)
                .text('Total de Depreciación');
        })
        .catch(error => console.error('Error fetching data:', error));
</script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
