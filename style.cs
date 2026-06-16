*{
    margin:0;
    padding:0;
    box-sizing:border-box;
    font-family:'Segoe UI', sans-serif;
}

body{
    background:#f4fbff;
    color:#1d3557;
    line-height:1.6;
}

header{
    height:100vh;
    background:
    linear-gradient(rgba(0,50,90,0.6), rgba(0,50,90,0.6)),
    url('https://images.unsplash.com/photo-1500375592092-40eb2168fd21?auto=format&fit=crop&w=1400&q=80');
    background-size:cover;
    background-position:center;
    display:flex;
    justify-content:center;
    align-items:center;
    text-align:center;
    color:white;
}

.hero h1{
    font-size:4rem;
    margin-bottom:20px;
}

.hero p{
    max-width:700px;
    margin:auto;
    font-size:1.3rem;
}

.btn{
    display:inline-block;
    margin-top:30px;
    padding:15px 30px;
    background:#00b4d8;
    color:white;
    text-decoration:none;
    border-radius:30px;
    transition:.3s;
}

.btn:hover{
    background:#0096c7;
}

section{
    padding:80px 10%;
}

.section-title{
    text-align:center;
    margin-bottom:50px;
    color:#0077b6;
    font-size:2.5rem;
}

.cards{
    display:grid;
    grid-template-columns:repeat(auto-fit,minmax(250px,1fr));
    gap:25px;
}

.card{
    background:white;
    padding:25px;
    border-radius:15px;
    box-shadow:0 5px 20px rgba(0,0,0,0.1);
    transition:.3s;
}

.card:hover{
    transform:translateY(-10px);
}

.card h3{
    color:#0096c7;
    margin-bottom:15px;
}

.stats{
    background:#0077b6;
    color:white;
    text-align:center;
}

.wave{
    font-size:3rem;
    margin-bottom:10px;
}

.counter{
    font-size:3rem;
    font-weight:bold;
}

.solutions{
    background:#e0f7ff;
}

footer{
    background:#023e8a;
    color:white;
    text-align:center;
    padding:30px;
}

@media (max-width:768px){

    .hero h1{
        font-size:2.8rem;
    }

    .hero p{
        font-size:1rem;
        padding:0 20px;
    }

    .section-title{
        font-size:2rem;
    }

    .counter{
        font-size:2.2rem;
    }
}
