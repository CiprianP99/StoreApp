import Slider from "react-slick";


export default function HomePage(){
    const settings = {
        dots: true,
        infinite: true,
        speed: 500,
        slidesToShow: 1,
        slidesToScroll: 1
    };

    return(
        <>
        <Slider {...settings}>
        <div >
            <img src="/images/slider/amd.jpg" alt="amd" style={{display:'block', width: '70%', maxHeight: 500, margin:'auto'}} />
        </div>
        <div>
            <img src="/images/slider/apple.jpg" alt="apple" style={{display:'block', width: '70%', maxHeight: 500, margin:'auto'}} />
        </div>
        <div>
            <img src="/images/slider/asus.jpg" alt="asus" style={{display:'block', width: '70%', maxHeight: 500, margin:'auto'}} />
        </div>
        </Slider>
        </>
    )
}