import React from 'react';
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

import { useState } from 'react';

import './App.css';

function App() {
  return (
    <div className="page-container">
      <div className="button-container">
        <button className="image-button">Главная</button>
        <button className="image-button">Бронирование</button>
        <button className="image-button">Акции</button>
        <button className="image-button">Отзывы</button>
        <button className="image-button">Галлерея</button>
        <button className="image-button">Контакты</button>
        <button className="lang-button">RU</button>
        <button className="login-button">Личный кабинет</button>
      </div>
      <div className="first-content-container">
        <div className='main-image-container'>
          <img src={firstImage} alt="First Image" className="firstImage" />
          <div className="enjoy-the-trip">Насладись прогулкой на лошадях <br /> в компании любимых</div>
        </div>
        <div className="second-content-container">
          <img src={secondImage} alt="Second Image" className="secondImage" />
          <div className="second-page-content">
            <p className="about-us">о нас</p>
            <p className="extrabold-32">
              Добро пожаловать в Health Club – <br /> ваш путь к миру верховой езды!
            </p>
            <p className="company-desc">Мы рады приветствовать вас в нашем уголке природы и <br /> элегантности, где связь с природой, верховая езда и забота о <br /> здоровье сливаются в единое вдохновляющее приключение. <br /> Health Club – это не просто компания, это стиль жизни, <br /> воплощенный в искусстве верховой езды и гармонии с природой.</p>
            <button className="book-trip">Забронировать!</button>
          </div>
        </div>

        <div className="third-content-container">
          <div className="third-page-content">
            <p className="about-us-third">о нас</p>
            <p className="extrabold-32-third">
              Наша миссия:
            </p>
            <p className="company-desc-34">Мы стремимся к тому, чтобы каждый наш гость ощутил волшебство <br /> общения с лошадьми и природой. Ведь верховая езда – это не <br /> только физическая активность, но и искусство понимания и <br /> взаимодействия с этими удивительными животными. Мы создаем <br /> уникальные возможности для всех – от новичков до опытных <br /> наездников – погрузиться в мир конного спорта и открыть для себя <br /> новые грани взаимоотношений между человеком и лошадью. </p>
            <div className="miniature-text-container">
              <img src={miniature1} alt="Miniature 1" className="miniature" />
              <div className="text-section">
                <p className="bold-18">Опытные инструкторы</p>
                <p className="miniature-text">Наши опытные инструкторы помогут вам совершенствовать навыки <br /> верховой езды, независимо от вашего опыта.</p>
              </div>
            </div>
            <div className="miniature-text-container">
              <img src={miniature2} alt="Miniature 2" className="miniature" />
              <div className="text-section">
                <p className="bold-18">Безопасный поход</p>
                <p className="miniature-text">Мы придерживаемся высоких стандартов безопасности, обеспечивая <br /> занятия надежными лошадьми и опытными профессионалами.</p>
              </div>
            </div>
            <div className="miniature-text-container">
              <img src={miniature3} alt="Miniature 3" className="miniature" />
              <div className="text-section">
                <p className="bold-18">Лояльные цены</p>
                <p className="miniature-text">Мы предлагаем доступные цены, чтобы каждый мог насладиться <br /> радостью верховой езды и природой.</p>
                <button className="directions-button">О направлениях</button>
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
            <p className="directions-yellow">по версии отдыхающих</p>
            <p className="extrabold-32-fourth">Популярные направлениия</p>
            <div className="image-row">
              <div className="directions-container">
                <img src={direction1} alt="Direction 1" className="directions" />
                <div class="directions-content">
                  <div className="directions-rectangle">
                    <div className="directions-description">Прогулки в горы</div>
                    <div className="directions-rectangle-small">
                      <div className="price">1200с/час</div>
                    </div>
                  </div>
                </div>
              </div>
              <div className="directions-container">
                <img src={direction2} alt="Direction 2" className="directions" />
                <div className="directions-rectangle">
                  <div className="directions-description">&nbsp;Прогулки по манежу</div>
                  <div className="directions-rectangle-small">
                    <div className="price">600с/полчаса</div>
                  </div>
                </div>
              </div>
              <div className="directions-container">
                <img src={direction3} alt="Direction 3" className="directions" />
                <div className="directions-rectangle">
                  <div className="directions-description">Иппотерапия</div>
                  <div className="directions-rectangle-small">
                    <div className="price">600с/полчаса</div>
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

