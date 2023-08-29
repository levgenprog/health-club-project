import React from 'react';
import firstImage from '../assets/firstImage.jpg';
import secondImage from '../assets/secondImage.jpg'; // Import the second image
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
      <div className="content-container">
       <img src={firstImage} alt="First Image" className="firstImage" />
       <div className="bottom-left-text">Насладись прогулкой на лошадях <br /> в компании любимых</div>
       <div className="second-image-container">
        <img src={secondImage} alt="Second Image" className="secondImage" />
        <div className="Добро пожаловать">
            Добро пожаловать в Health Club – ваш путь к миру верховой езды!
          </div>
      </div>
    </div>
   </div>
  );
}

export default App;
