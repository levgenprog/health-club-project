import Button from "./UI/Button";

const menuItems = [
    {
        name: 'Главная',
        id: 'main'
    },
    {
        name: 'Бронирование',
        id: 'book'
    },
    {
        name: 'Акции',
        id: 'actia'
    },
    {
        name: 'Отзывы',
        id: 'book'
    },
    {
        name: 'Галерея',
        id: 'gal'
    },
    {
        name: 'Контакты',
        id: 'gal'
    },
];
\
const Menu = () => {



    return (
        <div className="button-container">
            {menuItems.map((item, index) => {
                return(
                    <a href={`#${item.id}`}>
                        <Button key={index} action={() => {}} children={item.name}></Button>
                    </a>
                    
                )
            })}
        <select className="lang-button">
          <option value="en">EN</option>
          <option value="ru" selected>RU</option>
        </select>
        <button className="login-button">
          Регистрация
        </button>
      </div>
    )
}

export default Menu;