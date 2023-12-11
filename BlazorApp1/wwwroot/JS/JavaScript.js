function updateTimeElement(id, newText) {
    var element = document.getElementById(id);
    if (element) {
        element.innerText = 'Time : ' + newText;
    }
}

window.updateTimeElement = updateTimeElement;
