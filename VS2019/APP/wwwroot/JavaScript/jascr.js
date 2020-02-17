function onBlazorReady() {
  
  var oldDiv = 'inicio';
  $(".opcoesbtn").click(function () {
    /*falta descobrir as classes q o old div tem*/
    var parentdiv = $(this).parent().parent().children(".Net_Options_Sub_Menu");
    var test = oldDiv[0] === parentdiv[0];
    if (test || oldDiv == 'inicio') {
        FlipRotacao(parentdiv);
        parentdiv.slideToggle(300);
    } else {
        var oldDivFechado = oldDiv["0"].style.display == "none";
        var parentDivFechado = oldDiv["0"].style.display == "none";
        if (oldDivFechado && parentDivFechado) {
            FlipRotacao(parentdiv);
            parentdiv.slideToggle(300);
        } else{
          FlipRotacao(oldDiv);
        oldDiv.slideUp(150);
        FlipRotacao(parentdiv);
        parentdiv.slideToggle(300);
        }

    }
    oldDiv = parentdiv;
    console.log(parentdiv);
})
}

var MenuInteger = 0;
var elmnt
function MenuUpOrDown(myInt) {
  if (MenuInteger == myInt) {
      $("#options-div").slideUp(300);
      MenuInteger = 0;
  } else {
      $("#options-div").slideDown(300);
      switch (myInt) {
        case 1:
          elmnt = $('#bloco1')[0];
          elmnt.scrollIntoView(true);
          break;
        case 2:
          elmnt = $('#bloco2')[0];
          elmnt.scrollIntoView(true);
          break;
        case 3:
          elmnt = $('#bloco3')[0];
          elmnt.scrollIntoView(true);
          break;
      }
      MenuInteger = myInt;
  }
}

function FlipRotacao(Elem) {
  var svgElem = $(Elem).parent().find("svg.TogglingArrow");
  if (svgElem["0"].style.transform == "rotateX(0deg)") {
    svgElem["0"].style.transform = "rotateX(180deg)"
  } else if (svgElem["0"].style.transform == "rotateX(180deg)") {
    svgElem["0"].style.transform = "rotateX(0deg)"
  }
  
}