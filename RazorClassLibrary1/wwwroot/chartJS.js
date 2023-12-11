window.chartInterop = {
    createChart: (canvasId, chartType, data, options) => {
        const ctx = document.getElementById(canvasId).getContext('2d');
        new Chart(ctx, {
            type: chartType,
            data: data,
            options: options
        });
    }
};
