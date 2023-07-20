// Porto koster X -  Frimærker koster 3 og 5 cents. 
// Program som  fordele frimærker som passer til X pris: 
    const stamps = [];
    var porto = 21;   // varierer
    var remainder = porto % 5;
 
    console.log("Rest: "+ remainder);
 
    for(i=porto; i > 4; i -= 5){
        stamps.push(5) 
        }
    if(remainder == 1){
         stamps.pop();
         stamps.push(3,3);
    } 
    else if(remainder==2){
        stamps.pop();
        stamps.pop();
        stamps.push(3,3,3,3)
    }
    else if(remainder==3){
        stamps.push(3)
    }
    else if(remainder==4){
        stamps.pop();
        stamps.push(3,3,3)
    };