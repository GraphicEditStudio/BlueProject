var starNumber = 30
var stoneNumber = 12
var shipNumber = 1 //player ship
var enemyNumber = 2 //enemy ship

var starSpeed = 1
var stoneSpeed = 3
var shipSpeed = 5
var enemySpeed = 4

var boxWidth = 1280;
var boxHeight = 720;

function rn(start, end) {
    var diff = end - start;
    return Math.floor((Math.random())*diff + start);
  }

var oneShot = false;
function addThings(){
    if(!oneShot){
        oneShot= true;
        var body = document.body
        //stars
        for (var i=0; i<starNumber;i++){
            var img = document.createElement("img");
            img.src = "./textures/star.gif";
            var imgTop = rn(0,boxHeight);
            var imgLeft = rn(0,boxWidth);
            
            var unit = "px";
            img.style.setProperty("top", imgTop.toString()+unit);
            img.style.setProperty("left", imgLeft.toString()+unit);
            img.setAttribute("id", "star"+i.toString());
            body.appendChild(img);
        }
        
        //stone
        for (var i=0; i<stoneNumber;i++){
            var img = document.createElement("img");
            img.src = "./textures/stone.gif";
            var imgTop = rn(0,boxHeight);
            var imgLeft = rn(0,boxWidth);
            
            var unit = "px";
            img.style.setProperty("top", imgTop.toString()+unit);
            img.style.setProperty("left", imgLeft.toString()+unit);
            img.setAttribute("id", "stone"+i.toString());
            body.appendChild(img);
        }
        
        //ship
        for (var i=0; i<shipNumber;i++){
            var img = document.createElement("img");
            img.src = "./textures/ship.gif";
            var imgTop = rn(0,boxHeight);
            var imgLeft = rn(0,boxWidth);
            
            var unit = "px";
            img.style.setProperty("top", imgTop.toString()+unit);
            img.style.setProperty("left", 0.2*boxWidth.toString()+unit);
            img.setAttribute("id", "ship"+i.toString());
            body.appendChild(img);
        }
        
        //enemyShip
        for (var i=0; i<enemyNumber;i++){
            var img = document.createElement("img");
            img.src = "./textures/enemy.gif";
            var imgTop = rn(0,boxHeight);
            var imgLeft = rn(0,boxWidth);
            
            var unit = "px";
            img.style.setProperty("top", imgTop.toString()+unit);
            img.style.setProperty("left", imgLeft.toString()+unit);
            img.setAttribute("id", "enemy"+i.toString());
            body.appendChild(img);
        }
    }
}
addThings();

function moveLeft(speed,id){
    var unit = "px"
    var item = document.getElementById(id)
    var left = parseInt(item.style.left)
    var width = item.clientWidth;
    if (left< -width){left = boxWidth}else {left-=speed}
    left = left.toString()+unit;
    item.style.setProperty("left", left);
}

function moveUp(speed,id){
    var unit = "px"
    var item = document.getElementById(id)
    var top = parseInt(item.style.top)
    var height = item.clientHeight;
    top-=speed
    top = top.toString()+unit;
    item.style.setProperty("top", top);
}

function moveDn(speed,id){
    var unit = "px"
    var item = document.getElementById(id)
    var top = parseInt(item.style.top)
    var height = item.clientHeight;
    top+=speed
    top = top.toString()+unit;
    item.style.setProperty("top", top);
}

var followUp = false;
var oldUp=false;
function animate(){
    //ship
    for(var i=0;i<shipNumber;i++){
        var id = "ship"+i.toString()
        var item = document.getElementById(id)
        var top = parseInt(item.style.top);
        if(top < 0 && followUp || top< boxHeight && !followUp){
            followUp = false;
            moveDn(shipSpeed,id)
        }else if(top>boxHeight && !followUp || top>0 && followUp){
            followUp=true;
            moveUp(shipSpeed,id)
        }
    }
    
    //enemy
    for(var i=0;i<enemyNumber;i++){
        var id = "enemy"+i.toString()
        moveLeft(enemySpeed, id);
    }
    
    //stones
    for(var i=0;i<stoneNumber;i++){
        var id = "stone"+i.toString()
        moveLeft(stoneSpeed, id);
    }
    
    //stars
    for(var i=0;i<starNumber;i++){
        var id = "star"+i.toString()
        moveLeft(starSpeed, id);
    }
}

setInterval( animate, 20);
