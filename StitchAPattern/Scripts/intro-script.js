var img = new Image();
var div = document.getElementById('foo');

img.onload = function () {
    div.appendChild(img);
};

img.src = 'C:\Users\Elizabeth\Documents\GitHub\StitchAPattern\StitchAPattern\Content\Images\9R36p.png';