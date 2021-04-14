// Put your code here

console.log("My Enemies List!")
console.log("-------------")


const enemyList = [
    {
        firstName: "Joshua",
        lastName: "Flowers",
        offences: ["Being a jerk to me in elementary school", "Not being nice to me to me in elementary school"],
        isReallyHated: true
    },
    {
        firstName: "Darth",
        lastName: "Vader",
        offences: ["Cut off Luke's hand", "Murdered all those kids", "Unkind mangement practices"],
        isReallyHated: false
    },
    {
        firstName: "Betty",
        lastName: "Rudelady",
        offences: ["Phone calls in the theater", "Phone calls on the bus", "Phone calls in line at the grocery store", "Poor conversationalist"],
        isReallyHated: true
    },
    {
        firstName: "Leon",
        lastName: "Peck",
        offences: ["Keeps giving me a hotplate"],
        isReallyHated: false
    }
]

for(let enemy of enemyList){
    if(enemy.isReallyHated === true){
        console.log(enemy.firstName, enemy.lastName, "(Really, really dislike!)") 
    } else{
        console.log(enemy.firstName, enemy.lastName)
    }
}