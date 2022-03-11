import { Container, Grid, Box, Link } from '@mui/material'


export default function Footer() {
    return (
        <div>
            <Box
                px={{ xs: 3, sm: 10 }}
                py={{ xs: 3, sm: 3 }}
                bgcolor="text.secondary"
                color="white"
                style={{ marginTop: "20px"}}>
                <Container maxWidth="lg" >
                    <Grid container spacing={5} textAlign="center">
                        <Grid item xs={12} sm={6}>
                            <Box borderBottom={1}>Help</Box>
                            <Box>
                                <Link href="#" color="inherit">Contact</Link>
                            </Box>
                            <Box>
                                <Link href="#" color="inherit">Support</Link>
                            </Box>
                            <Box>
                                <Link href="#" color="inherit">Privacy</Link>
                            </Box>

                        </Grid>
                        <Grid item xs={12} sm={6}>
                            <Box borderBottom={1}>Social Media</Box>
                            <Box>
                                <Link href="https://ro-ro.facebook.com/" color="inherit">Facebook</Link>
                            </Box>
                            <Box>
                                <Link href="https://myaccount.google.com/" color="inherit">Google</Link>
                            </Box>
                            <Box>
                                <Link href="https://www.instagram.com/" color="inherit">Instagram</Link>
                            </Box>

                        </Grid>


                    </Grid>
                    <Box textAlign="center" pt={{ xs: 2, sm: 3 }} pb={{ xs: 2, sm: 0 }}>
                        Electronix &reg; {new Date().getFullYear()}
                    </Box>
                </Container>
            </Box>
        </div>
    )
}