document.getElementById("addButton").addEventListener("click", () => {

    //Ezt az objektumot fogjuk átküldeni
    let data = {
        jokeText: document.getElementById("jokeText").value
    }


    fetch("api/jokes",
        {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(data)
        }).then(x => {
            if (x.ok) {
                alert("Siker");

            }
            else {
                alert("Kudarc");
            }
        });	

});