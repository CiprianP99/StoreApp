import { Avatar, Container, Typography} from "@mui/material";
import emailjs from 'emailjs-com';

export default function ContactPage() {
    function sendEmail(e: React.FormEvent<HTMLFormElement>) {
        e.preventDefault();
        emailjs.sendForm("service_74690pc", "template_xjcz7vp", e.currentTarget, "8UZhi6_vV7d3Iy-0S")
        .then(
            (result) => {
              console.log(result.text);
            },
            (error) => {
              console.log(error.text);
            }
          );
          e.currentTarget.reset();
    }
    return (
        <Container maxWidth="sm" sx={{display: 'flex', flexDirection: 'column',
         alignItems:'center', p: 4, bgcolor:'#BDC3C7', borderRadius:'14px',
         border:'3px solid #8E24AA'}}>
            <Avatar sx={{m: 1, bgcolor:'secondary.main'}}>
                
                </Avatar>
                <Typography component="h1" variant="h5">
                    Contact Us

                </Typography>
                <form className="row" style={{margin: "25px 85px 75px 100px"}} onSubmit={sendEmail}>
                    <label>Name</label>
                    <input type="text" name ="name" className="form-control" />

                    <label>Email</label>
                    <input type="email" name = "user_email" className="form-control" />

                    <label>Message</label>
                    <textarea name='message'  className="form-control" />
                    <input type='submit' value='Send'  className="form-control btn btn-primary" style={{marginTop: "30px"}}/>
                </form>
                
            
        </Container>

    )
}