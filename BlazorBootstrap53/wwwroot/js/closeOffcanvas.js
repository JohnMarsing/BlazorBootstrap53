window.closeOffcanvas = function () {
  // Assuming you have a div with id "offcanvasid" for the offcanvas component
  var offcanvasElement = document.getElementById("offcanvasid");
  var offcanvas = new bootstrap.Offcanvas(offcanvasElement);
  //console.log("calling `offcanvas.hide`");
  offcanvas.hide();
};