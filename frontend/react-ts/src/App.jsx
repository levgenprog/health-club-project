import React, { useState } from 'react';
import firstImage from '../assets/firstImage.jpg';
import secondImage from '../assets/secondImage.jpg';
import thirdImage from '../assets/thirdImage.jpg';
import fourthImage from '../assets/fourthImage.jpg';
import fifthImage from '../assets/fifthImage.jpg';
import sixthImage from '../assets/sixthImage.jpg';
import miniature1 from '../assets/miniature1.png';
import miniature2 from '../assets/miniature2.png';
import miniature3 from '../assets/miniature3.png';

import direction1 from '../assets/direction1.jpeg';
import direction2 from '../assets/direction2.jpg';
import direction3 from '../assets/direction3.jpg';

import './App.css';

function App() {

  const [selectedLanguage, setSelectedLanguage] = useState('ru');

  const buttonTranslations = {
    ru: {
      home: 'Главная',
      booking: 'Бронирование',
      offer: 'Акции',
      review: 'Отзывы',
      gallery: 'Галлерея',
      contact: 'Контакты',
      login: 'Личный кабинет',
      enjoy: 'Насладись прогулкой на лошадях <br /> в компании любимых',
      about: 'о нас',
      welcome: 'Добро пожаловать в Health Club – <br /> ваш путь к миру верховой езды!',
      wearehappy: 'Мы рады приветствовать вас в нашем уголке природы и <br /> элегантности, где связь с природой, верховая езда и забота о <br /> здоровье сливаются в единое вдохновляющее приключение. <br /> Health Club – это не просто компания, это стиль жизни, <br /> воплощенный в искусстве верховой езды и гармонии с природой.',
      booknow: 'Забронировать!',
      ourmission: 'Наша миссия:',
      desc: 'Мы стремимся к тому, чтобы каждый наш гость ощутил волшебство <br /> общения с лошадьми и природой. Ведь верховая езда – это не <br /> только физическая активность, но и искусство понимания и <br /> взаимодействия с этими удивительными животными. Мы создаем <br /> уникальные возможности для всех – от новичков до опытных <br /> наездников – погрузиться в мир конного спорта и открыть для себя <br /> новые грани взаимоотношений между человеком и лошадью.',
      instructors: 'Опытные инструкторы',
      instructorsdesc: 'Наши опытные инструкторы помогут вам совершенствовать навыки <br /> верховой езды, независимо от вашего опыта.',
      safety: 'Безопасный поход',
      safetydesc: 'Мы придерживаемся высоких стандартов безопасности, обеспечивая <br /> занятия надежными лошадьми и опытными профессионалами.',
      price: 'Лояльные цены',
      pricedesc: 'Мы предлагаем доступные цены, чтобы каждый мог насладиться <br /> радостью верховой езды и природой.',
      aboutdirections: 'О направлениях',
      peoplethink: 'по версии отдыхающих',
      populardir: 'Популярные направлениия',
      mountains: 'Прогулки в горы',
      manej: 'Прогулки по манежу',
      terapy: 'Иппотерапия',
      price600: '600с/полчаса',
      price1200: '1200с/час',
    },
    en: {
      home: 'Home',
      booking: 'Booking',
      offer: 'Special Offers',
      review: 'Reviews',
      gallery: 'Gallery',
      contact: 'Contacts',
      login: 'Login',
      enjoy: 'Enjoy horseback riding <br /> with your loved ones',
      about: 'about us',
      welcome: 'Welcome to the Health Club - <br /> your way to the world of horse riding!',
      wearehappy: 'We welcome you to our corner of nature and <br /> elegance, where connection with nature, horseback riding and <br /> health merge into one inspiring adventure. <br /> Health Club is not just a company, it is a lifestyle, <br /> embodied in the art of riding and harmony with nature.',
      booknow: 'Book now!',
      ourmission: 'Our mission',
      desc: 'We strive to ensure that each of our guests feel the magic <br /> of communication with horses and nature. After all, horseback riding is not only <br /> physical activity, but also the art of understanding and <br /> interacting with these amazing animals. We create <br /> unique opportunities for everyone - from beginners to experienced <br /> riders - to immerse themselves in the world of equestrian sports and discover <br /> new facets of the relationship between man and horse.',
      instructors: 'Experienced instructors',
      instructorsdesc: 'Our experienced instructors will help you improve your riding <br /> skills, regardless of your experience.',
      safety: 'Safety',
      safetydesc: 'We maintain high safety standards by providing <br /> lessons with reliable horses and experienced professionals.',
      price: 'Loyal prices',
      pricedesc: 'We offer affordable prices so that everyone can enjoy <br /> the joy of horseback riding and nature.',
      aboutdirections: 'Our services',
      peoplethink: 'according to vacationers',
      populardir: 'Popular rides',
      manej: 'Arena rides',
      mountains: 'Rides in the mointains',
      terapy: 'Hippotherapy',
      price600: '600s/half-hour',
      price1200: '1200s/hour',
    },
  };

  const handleLanguageChange = (event) => {
    setSelectedLanguage(event.target.value);
  };


  return (
    <div className="page-container">
      <div className="button-container">
        <button className="image-button">
          {buttonTranslations[selectedLanguage].home}
        </button>
        <button className="image-button">
          {buttonTranslations[selectedLanguage].booking}
        </button>
        <button className="image-button">
          {buttonTranslations[selectedLanguage].offer}
        </button>
        <button className="image-button">
          {buttonTranslations[selectedLanguage].review}
        </button>
        <button className="image-button">
          {buttonTranslations[selectedLanguage].gallery}
        </button>
        <button className="image-button">
          {buttonTranslations[selectedLanguage].contact}
        </button>
        <select className="lang-button" onChange={handleLanguageChange}>
          <option value="en">EN</option>
          <option value="ru" selected>RU</option>
        </select>
        <button className="login-button">
          {buttonTranslations[selectedLanguage].login}
        </button>
      </div>
      <div className="first-content-container">
        <div className='main-image-container'>
          <img src={firstImage} alt="First Image" className="firstImage" />
          <div className="enjoy-the-trip">{buttonTranslations[selectedLanguage].enjoy.split('<br />').map((line, index, array) => (
            <React.Fragment key={index}>
              {line}
              {index !== array.length - 1 && <br />}
            </React.Fragment>
          ))}</div>
        </div>
        <div className="second-content-container">
          <img src={secondImage} alt="Second Image" className="secondImage" />
          <div className="second-page-content">
            <p className="about-us">{buttonTranslations[selectedLanguage].about}</p>
            <p className="extrabold-32">
              {buttonTranslations[selectedLanguage].welcome.split('<br />').map((line, index, array) => (
                <React.Fragment key={index}>
                  {line}
                  {index !== array.length - 1 && <br />}
                </React.Fragment>
              ))}
            </p>
            <p className="company-desc">
              {buttonTranslations[selectedLanguage].wearehappy.split('<br />').map((line, index, array) => (
                <React.Fragment key={index}>
                  {line}
                  {index !== array.length - 1 && <br />}
                </React.Fragment>
              ))}
            </p>

            <button className="book-trip">{buttonTranslations[selectedLanguage].booknow}</button>
          </div>
        </div>

        <div className="third-content-container">
          <div className="third-page-content">
            <p className="about-us-third">{buttonTranslations[selectedLanguage].about}</p>
            <p className="extrabold-32-third">
              {buttonTranslations[selectedLanguage].ourmission}
            </p>
            <p className="company-desc-34">{buttonTranslations[selectedLanguage].desc.split('<br />').map((line, index, array) => (
              <React.Fragment key={index}>
                {line}
                {index !== array.length - 1 && <br />}
              </React.Fragment>
            ))} </p>
            <div className="miniature-text-container">
              <img src={miniature1} alt="Miniature 1" className="miniature" />
              <div className="text-section">
                <p className="bold-18">{buttonTranslations[selectedLanguage].instructors}</p>
                <p className="miniature-text">{buttonTranslations[selectedLanguage].instructorsdesc.split('<br />').map((line, index, array) => (
                  <React.Fragment key={index}>
                    {line}
                    {index !== array.length - 1 && <br />}
                  </React.Fragment>
                ))}</p>
              </div>
            </div>
            <div className="miniature-text-container">
              <img src={miniature2} alt="Miniature 2" className="miniature" />
              <div className="text-section">
                <p className="bold-18">{buttonTranslations[selectedLanguage].safety}</p>
                <p className="miniature-text">{buttonTranslations[selectedLanguage].safetydesc.split('<br />').map((line, index, array) => (
                  <React.Fragment key={index}>
                    {line}
                    {index !== array.length - 1 && <br />}
                  </React.Fragment>
                ))}</p>
              </div>
            </div>
            <div className="miniature-text-container">
              <img src={miniature3} alt="Miniature 3" className="miniature" />
              <div className="text-section">
                <p className="bold-18">{buttonTranslations[selectedLanguage].price}</p>
                <p className="miniature-text">{buttonTranslations[selectedLanguage].pricedesc.split('<br />').map((line, index, array) => (
                  <React.Fragment key={index}>
                    {line}
                    {index !== array.length - 1 && <br />}
                  </React.Fragment>
                ))}</p>
                <button className="directions-button">{buttonTranslations[selectedLanguage].aboutdirections}</button>
              </div>
            </div>
          </div>
          <div className="image-square">
            <img src={thirdImage} alt="Third Image" className="images" />
            <img src={fourthImage} alt="Fourth Image" className="images" />
            <img src={fifthImage} alt="Fifth Image" className="images" />
            <img src={sixthImage} alt="Sixth Image" className="images" />
          </div>
        </div>

        <div className="fourth-content-container">
          <div className="fourth-page-content">
            <p className="directions-yellow">{buttonTranslations[selectedLanguage].peoplethink}</p>
            <p className="extrabold-32-fourth">{buttonTranslations[selectedLanguage].populardir}</p>
            <div className="image-row">
              <div className="directions-container">
                <img src={direction1} alt="Direction 1" className="directions" />
                <div class="directions-content">
                  <div className="directions-rectangle">
                    <div className="directions-description">{buttonTranslations[selectedLanguage].mountains}</div>
                    <div className="directions-rectangle-small">
                      <div className="price">{buttonTranslations[selectedLanguage].price1200}</div>
                    </div>
                  </div>
                </div>
              </div>
              <div className="directions-container">
                <img src={direction2} alt="Direction 2" className="directions" />
                <div className="directions-rectangle">
                  <div className="directions-description">&nbsp;{buttonTranslations[selectedLanguage].manej}</div>
                  <div className="directions-rectangle-small">
                    <div className="price">{buttonTranslations[selectedLanguage].price600}</div>
                  </div>
                </div>
              </div>
              <div className="directions-container">
                <img src={direction3} alt="Direction 3" className="directions" />
                <div className="directions-rectangle">
                  <div className="directions-description">{buttonTranslations[selectedLanguage].terapy}</div>
                  <div className="directions-rectangle-small">
                    <div className="price">{buttonTranslations[selectedLanguage].price600}</div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div >

  );
}

export default App;




