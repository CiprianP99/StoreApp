import { Grid } from "@mui/material";

export default function AboutPage(){
    return(
        <Grid container spacing={0} style={{marginTop:'30px'}}>
            <Grid item xs={8}>

            <div style={{textAlign:'center'}}>
            <iframe title='myFrame' src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d11418.611060553218!2d23.786457136528853!3d44.31708846566428!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4752d79f063ebc91%3A0x17f585b59ff94a7!2sCentru%2C%20Craiova!5e0!3m2!1sro!2sro!4v1646665888894!5m2!1sro!2sro" width="600" height="450" style={{ border: '0', margin:'auto' }} loading="lazy"></iframe>
            </div>
            </Grid>
            <Grid item xs={4} style={{borderLeft:'1px solid black', paddingLeft:'30px'}}>
            <div style={{paddingTop:'160px'}}>
                <p>Craiova</p>
                <p>Strada Sfintii Apostoli</p>
                <p>Bloc A42, Scara A</p>
                
            </div>
            </Grid>
        </Grid>
    )
}