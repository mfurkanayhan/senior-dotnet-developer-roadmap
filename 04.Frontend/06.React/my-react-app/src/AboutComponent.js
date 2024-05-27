import { useEffect, useState } from "react";

export function AboutComponent(){
    const [isColorRed, setIsColorRed] = useState(false);

    function changeColor(){
        setIsColorRed((prev)=> !prev);
    }

    function showButton(){
        if(isColorRed){
            return (<button style={{backgroundColor: "red", color:"white"}}>Red</button>)
        }else{
            return (<button style={{backgroundColor: "blue", color:"white"}}>Blue</button>)
        }
    }

    return(
        <>
        <h1>About page</h1>
        <button onClick={changeColor}>Change Color</button>
        <br />
        {showButton()}
        </>
    )
}