import React from 'react'
import Logo from '../../Images/logo.png'

const Header = () => {
  return (
    <div className='tennis_header bg-slate-500 text-white fixed w-full z-auto top-0' id='tennisTour'>
      <div className='tennis_header_1 bg-red-400 flex min-h-8 items-center'>
        <div className='wrapper flex items-center content-between flex-grow'>
          <div className='text flex w-56 mx-40'>
            <span>TENNIS TOURNAMENTS</span>
          </div>
        </div>
      </div>

      <div className='tennis_header_2 bg-slate-800 min-h-24 flex items-center'>
        <div className='wrapper_1 flex items-center content-between flex-grow line-clamp-1'>
          <div className='section flex items-center'>
            <div className='logo flex items-center'>
              <a href='/' className='max-w-32 max-h-32 mx-40'>
                <img src={Logo} />
              </a>
            </div>
            <div className='navigation ml-auto'>
              <ul className='flex items-center gap-6'>
                <li className='item_1 hover:text-blue-800 mr-2 border-b-2 solid list-none p-2 relative'>Trang chủ</li>
                <li className='item_1 hover:text-blue-800 mr-2 border-b-2 solid list-none p-2 relative'>Giải đấu</li>
                <li className='item_1 hover:text-blue-800 mr-2 border-b-2 solid list-none p-2 relative'>Thông tin thêm</li>
                <li className='item_1 hover:text-blue-800 mr-2 border-b-2 solid list-none p-2 relative'>Tin tức</li>
              </ul>
            </div>
          </div>
          <div className='section flex items-center ml-64'>
            <div className='search w-6 h-6 border ml-2 flex items-center cursor-pointer'></div>
          </div>
        </div>
      </div>
    </div>
  )
}

export default Header
